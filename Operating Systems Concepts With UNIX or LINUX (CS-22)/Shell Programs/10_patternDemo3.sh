echo "Enter Num : "
read num
echo
for((i=1;i<=num;i++))
do
    for((k=1;k<=num-i;k++))
    do
        echo -n " "
    done
    for((j=1;j<=i;j++))
    do
        echo -n "* "
    done
    echo " "
done
for((i=1;i<=num;i++))
do
    for((k=1;k<i;k++))
    do
        echo -n " "
    done
    for((j=1;j<=num-i+1;j++))
    do
        echo -n "* "
    done
    echo " "
done