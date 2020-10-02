public class Solution {
    public bool ValidMountainArray(int[] A) {
        int climb=0;
        bool up=false;
        bool down=false;
        if(A.Length<3){
            return false;
        }

        for (int i=0;i<A.Length-1;i++){

            if(!up){
                if(A[i]<A[i+1]){
                    up=true;
                }
                else{
                    return false;
                }
            }
            else{

                if((A[i]<= A[i+1])&& down){
                    Console.WriteLine("Equal");
                    return false;
                }
                else if(!down&&(A[i]>A[i+1])){
                    down=true;
                }
                else if(A[i]==A[i+1]){
                    return false;
                }
                
            }
        }
        return true & down;
        
    }
}