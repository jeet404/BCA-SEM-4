number=1
echo "Enter Num : "
read ln
echo
for((i=1; i<=ln; i++))
do
  for((j=1; j<=i; j++))
  do
    echo -n "$number "
  done
    number=$((number + 1))
  echo
done