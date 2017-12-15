#!/bin/bash

FOLDER=$1
PASSWORD=$2
NAME="mysql"

echo $PASSWORD
echo $FOLDER

set -ev

CONTAINER=$(docker ps -a --filter "name=$NAME" -q);
IMAGE=$(docker images $NAME -q);
NETWORK=$(docker network ls --filter "name=local-network" -q);
RUNNING=$(docker ps --filter "name=$NAME" -q);

if [ ! -z $CONTAINER ]
then
    echo "Removing container..."
    docker rm -f $CONTAINER
else
    echo "No container found."
fi

if [ ! -z $IMAGE ]
then
    echo "Removing image..."
    docker rmi $IMAGE
else
    echo "No image found."
fi

if [ -z $NETWORK ]
then
    echo "No network found..."
    docker create network localnetwork
    echo "Network created."
else
    echo "Network found"
fi

echo "Building and running the container..."
docker run --name mysql -e MYSQL_ROOT_PASSWORD=$PASSWORD --network=local-network -d -v $FOLDER:/mnt -p 3306:3306 mysql/mysql-server

echo "Waiting until the container gets healthy..."

while [[ ! -z `docker ps -a | grep $NAME | grep starting` ]]
do
    sleep 5
done

sleep 10

echo "Entering on container..." 
docker exec -i $NAME bash < inside_mysql_container.sh

echo "Done!"
