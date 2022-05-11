using Lists;
using MyStack;


/*===========================*/
LinkedList intList = new LinkedList();
intList.AppendNode(3);
intList.AppendNode(4);
intList.AppendNode(10);
intList.AppendNode(8);

// Console.WriteLine(intList);
// intList.PrintLinkList();
// Console.WriteLine(intList.count);
Console.WriteLine(intList.FindByIndex(3));
Console.WriteLine(intList.head.data);


Stack myStack = new Stack();
myStack.Pop();
