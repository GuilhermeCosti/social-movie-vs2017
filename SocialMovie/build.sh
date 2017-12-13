docker rm -f socialmovie
docker rmi socialmovie
docker build -t socialmovie .
docker run -d --network=local-network -p 5000:80 --name socialmovie socialmovie

