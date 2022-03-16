destination_Path="/Users/Home/Desktop/"
b="C://check/test.txt"
if [ ! -f $b ]
then 
touch $b 
fi
a=`ls -l`
e="-----w--w-"
echo "\n$a" | sed '1d' > $b
g=`pwd`
while read line
do 
d=`echo "$line" | awk '{print $1}'`
if [ $e != $d ]
then
r=`echo "$line" | awk '{print $9}'`
echo "Can have copy permission $g/$r" 
{
cp $g/$r "$destination_Path" && echo "copied successfully"
} || {
echo "cannot copy due to some error"
}
#else
#r=`echo "$line" | awk '{print $9}'`
#echo "Cannot have copy permission $r"
fi
done <"$b"