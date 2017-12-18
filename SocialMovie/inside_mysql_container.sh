#!/bin/bash/

cd /mnt

echo "Creating database..."
mysql -u root -p"${MYSQL_PASS}" -e "create database socialmovie;"

echo "Populating database..."
mysql socialmovie < *.sql -u root -p"${MYSQL_PASS}"

echo "Adding user to it..."
mysql -u root -p"${MYSQL_PASS}" -e "grant all privileges on *.* to 'joao'@'%' identified by '${MYSQL_PASS}'"

echo "Exiting container..."
exit
    
