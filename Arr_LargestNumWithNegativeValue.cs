class HelloWorld {
    static void Main() {
        System.Console.WriteLine(largestK(new int[]{9,2,3,4,-9,-4,-5,-4}));   //9
        System.Console.WriteLine(largestK(new int[]{1,2,3,-4}));    //0
        System.Console.WriteLine(largestK(new int[]{1,2,3,-4,4}));  //4
    }
    public static int largestK(int[] arr){
        Array.Sort(arr);
        for(int i = 0; i < arr.Length; i++){
            int negVal = 0 - arr[i];
            int c = arr.Count(val => val == negVal);
            if(c>0)
                return negVal;
            else
                continue;
        }
        return 0;
    }
}