import java.util.Arrays;
public class ReverseArray {
  public static void main(String[] args) {
    int[] in = {1,2,3,4,5,6};
    int[] out = arrayReverse(in);
    System.out.println(Arrays.toString(out));

    in = new int[]{1,2,3,4,5,6};
    out = arrayReverse(in);
    System.out.println(Arrays.toString(out));
  }
  public static int[] arrayReverse(int[] arr){
    int[] output = new int[arr.length];
    for(int i = arr.length -1; i > -1; i--){
      output[arr.length -1 - i] = arr[i];
    }
    return output;
  }

  public static int[] arrayReverseInPlace(int[] arr){
    for(int i = arr.length -1; i > -1; i--){
      int temp = arr[arr.length -1 - i];
      arr[arr.length -1 - i] = arr[i];
      arr[i]  = temp;
    }
    return arr;
  }
}
