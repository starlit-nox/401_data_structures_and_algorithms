import java.util.Arrays;

class ArrayShift {
  public static void main(String[] args){
    int[] in = {1,2,3,4,5};
    int[] out = insertShiftArray(in, 10);
    System.out.println(Arrays.toString(out));
  }

  public static int[] insertShiftArray(int[] arr, int num){
    int[] out = new int[arr.length + 1];
    int i = 0;
    for(; i < arr.length / 2; i++){
      out[i] = arr[i];
    }
    out[i] = num;
    for(; i < arr.length; i++){
      out[i+1] = arr[i];
    }
    return out;
  }
}
