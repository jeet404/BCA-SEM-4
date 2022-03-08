#!/bin/sh

echo "Enter Number from 1 to 3 : "
read num
case $num in
1) echo "You entered 1" ;;
2) echo "You entered 2" ;;
3) echo "You entered 3" ;;
*) echo "You are Not Entered 1 to 3" ;;
esac
