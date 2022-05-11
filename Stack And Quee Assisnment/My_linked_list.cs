namespace Lists
{
  class ListNode{
    public int data;
    public ListNode next;

    public ListNode(int a){
      data = a;
      next = null;
    }
  }

  class LinkedList{

    public ListNode head;
    public int count;
    private int indexValue;

    public LinkedList(){
      head = null;
      count = 0;
    }
  
    public void AppendNode(int data){
      ListNode node = new ListNode(data);

      node.next = head;
      head = node;
      count ++;
    }

    public int FindByIndex(int index){
      int indexVal = 0;
      int iterations = 0;
      ListNode tempVal = head;

      while(tempVal != null){

        iterations ++;
        tempVal = tempVal.next;
        // indexVal = tempVal.data;
        if(iterations >= index){
          Console.WriteLine(iterations);
          indexVal = tempVal.data;
          break;
        }
         
         
        // Console.WriteLine(iterations);
      }
      // Console.WriteLine(indexVal);
      return indexVal;
    }

    public void FindLastIndex(){
    //   int indexVal = 0;
    //   int iterations = 0;
    //   ListNode tempVal = head;

    //   while(tempVal != null){

    //     iterations ++;
    //     tempVal = tempVal.next;
    //     // indexVal = tempVal.data;
    //     if(iterations >= 1){
    //       Console.WriteLine(iterations);
    //       indexVal = tempVal.data;
    //       // tempVal.data = null;
    //       break;
    //     }
         
         
    //     // Console.WriteLine(iterations);
    //   }
    //   // Console.WriteLine(indexVal);
    //   return indexVal;
    // head.data = null;
    }

    public void PrintLinkList(){
      ListNode tempVal = head;
      while(tempVal != null){
        Console.WriteLine(tempVal.data);
        tempVal = tempVal.next;
      }
    }
  }
}