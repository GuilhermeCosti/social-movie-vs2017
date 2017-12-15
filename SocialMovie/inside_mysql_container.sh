#!/bin/bash/

cd /mnt

echo "Creating database..."
mysql -u root -p'joaopio1234' -e 'create database socialmovie;'

echo "Populating database..."
mysql socialmovie < *.sql -u root -p'joaopio1234'

echo "Adding user to it..."
mysql -u root -p"joaopio1234" -e "grant all privileges on *.* to 'joao'@'172.18.0.3' identified by 'joaopio1234'"

echo "Exiting container..."
exit
    
