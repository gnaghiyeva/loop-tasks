let n=121
let sum=0;
let temp
let k;

temp=n;
while(n!=0){
 k=n%10;//121%10=1;   12%10=2;    1%10=1
 sum=(sum*10)+k;  //0*10+1=1;    1*10+2=12;    12*10+1=121
//  n=n/10; xeta verir
 n=parseInt(n/10); //121/10=12;    12/10=1;   1/10=0

}

if(temp==sum){
    console.log(temp+" "+"palindrom ededdir.")
}
else{
    console.log(temp+" "+"palindrom eded deyil.")
}
