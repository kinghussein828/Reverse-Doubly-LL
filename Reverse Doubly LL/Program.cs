/************************************************************/
/*File Info    : program that reverses the order of Doubly LL                   */
/*Version     : v1.0                                                                                 */
/*Date         : 12\11\2021                                                                      */
/*Author      : Hussein Mohamad ELnaggar                                             */
/************************************************************/
using System;

public class LinkedList
{

	static Node head;

	class Node
	{

		public int data;
		public Node next, prev;

		public Node(int d)
		{
			data = d;
			next = prev = null;
		}
	}

	/* The main function to reverse a Doubly Linked List */
	void reverse()
	{
		Node temp = null;
		Node current = head;

		/* swap next and prev for all nodes of
		doubly linked list */
		while (current != null)
		{
			temp = current.prev;
			current.prev = current.next;
			current.next = temp;
			current = current.prev;
		}

		/* check for the cases like empty list and
		list with only one node */
		if (temp != null)
		{
			head = temp.prev;
		}
	}

	/* Function to insert a node at the
	beginning of the Doubly Linked List */
	void push(int new_data)
	{


		Node new_node = new Node(new_data); //allocate node

		/* prev is always NULL, Because we are adding at the beginning*/
		new_node.prev = null;

		/* link the old list off the new node */
		new_node.next = head;

		/* change prev of head node to new node */
		if (head != null)
		{
			head.prev = new_node;
		}

		/* move the head to point to the new node */
		head = new_node;
	}

	/* Function to print nodes in a given
	doubly linked list */
	void printList(Node node)
	{
		while (node != null)
		{
			Console.Write(node.data + " ");
			node = node.next;
		}
	}

	// Driver code
	public static void Main(String[] args)
	{
		LinkedList list = new LinkedList();

		/*create a sorted linked list
		to test the functions Created linked
		list will be 5->4->3->2->1 */
		list.push(1);
		list.push(2);
		list.push(3);
		list.push(4);
		list.push(5);

		Console.WriteLine("BEFORE: ");
		list.printList(head);

		list.reverse();
		Console.WriteLine("");
		Console.WriteLine("AFTER: ");
		list.printList(head);
	}
}