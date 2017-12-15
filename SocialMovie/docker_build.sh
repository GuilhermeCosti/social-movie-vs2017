#!/bin/bash
CONTAINER=$(docker ps -a --filter "name=socialmovie" -q);
IMAGE=$(docker images socialmovie -q);
NETWORK=$(docker network ls --filter "name=local-network" -q);
RUNNING=$(docker ps --filter "name=socialmovie" -q);

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

echo "Building the docker image.."
docker build -f Dockerfile -t socialmovie .

if [ -z $NETWORK ]
then
    echo "No network found..."
    docker create network localnetwork
    echo "Network created."
else
    echo "Network found"
fi

echo "Running container..." 
docker run -d --network=local-network -p 5000:80 --name socialmovie socialmovie

if [ ! -z $RUNNING ]
then
    echo "The container is up and runnig!"
    echo "Done!"
fi


#docker rm -f socialmovie
#docker rmi socialmovie
#docker build -f Dockerfile -t socialmovie .
#docker run -d --network=local-network -p 5000:80 --name socialmovie socialmovie

