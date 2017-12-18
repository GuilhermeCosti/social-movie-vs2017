#!/bin/bash

FOLDER="0"
PASSWORD="0"

  while getopts d:p: OPCAO; do
     case "${OPCAO}" in
        d) FOLDER=${OPTARG};;
	p) PASSWORD=${OPTARG};;
     esac
  done

if [ \( $FOLDER == "0" \) -o \( $PASSWORD == "0" \) ]
then
    echo "mysql_build.sh -d {database_path} -p {database_password}"
    exit 0
fi

NAME="mysql"

echo $PASSWORD
echo $FOLDER

set -ev

CONTAINER=$(docker ps -a --filter "name=$NAME" -q);
IMAGE=$(docker images $NAME -q);
NETWORK=$(docker network ls --filter "name=localnetwork" -q);
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
    docker network create localnetwork
    echo "Network created."
else
    echo "Network found"
fi

echo "Building and running the container..."
docker run --name mysql -e MYSQL_ROOT_PASSWORD=$PASSWORD --network=localnetwork -d -v $FOLDER:/mnt -p 3306:3306 mysql/mysql-server

echo "Waiting until the container gets healthy..."

while [[ ! -z `docker ps -a | grep $NAME | grep starting` ]]
do
    sleep 5
done

sleep 10

echo "Entering on container..." 
docker exec -i -e MYSQL_PASS=$PASSWORD $NAME bash < inside_mysql_container.sh

echo "Done!"
