using Lists;

namespace MyStack
{
  class Stack
  {
    LinkedList stack = new LinkedList();
    public void Pop(){
      stack.head = null;
      stack.PrintLinkList();
    }

    public void push(int value){
      stack.AppendNode(value);
    }

    public void Peek(){
      stack.FindByIndex(1);
    }
  }
}