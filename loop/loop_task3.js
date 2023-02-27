eded=5
sum=0;
for(var i = 2; i < eded; i++)//i ededler
{
  for (var j = 2; j < i; j++)// j ise bolenler  //let ile yazanda xeta verdi ona gore var ile yazdim :(
    {
      if(i % j == 0)
          break;
    }
	if (i == j)
    
		// console.log(i);
        sum=sum+i;
}console.log(sum)


