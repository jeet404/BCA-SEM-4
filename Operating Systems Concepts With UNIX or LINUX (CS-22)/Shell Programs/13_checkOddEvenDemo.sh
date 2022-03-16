echo "Enter Any Number : "
read num

res=`expr $num % 2` 

if [ $res -eq 1 ]; then
    echo "$num is Odd."
else
    echo "$num is Even."
fi