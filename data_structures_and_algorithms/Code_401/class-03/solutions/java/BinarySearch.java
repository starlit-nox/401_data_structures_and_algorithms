class BinarySearch {
  public static void main(String[] args){
    int[] nums = {1,2,3,4,5,6,7,8,9,10,11};
    int index = binarySearch(nums, 2);
    System.out.println(index);
    index = binarySearch(nums, 200);
    System.out.println(index);
    index = binarySearch(nums, 3);
    System.out.println(index);
    index = binarySearch(nums, 4);
    System.out.println(index);
    index = binarySearch(nums, 5);
    System.out.println(index);
    index = binarySearch(nums, 1);
    System.out.println(index);
  }

  public static int binarySearch(int[] arr, int num){
    int start = 0;
    int end = arr.length;
    int mid;

    while(end - start > 0){
      mid = (start + end) / 2;
      if(arr[mid] == num) return mid;
      if(num > arr[mid]) start = mid + 1;
      else end = mid;
    }
    return -1;
  }
}
