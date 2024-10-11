using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long hap = 0;
        
        for(int i = 1; i <= count ; i ++){
            hap += price * i;
        }
             return (hap > money) ? hap - money : 0;
            
        }
        
    }