package main

import "fmt"

type Node struct {
	data int
	next *Node
}

type List struct {
	head *Node
}

func (l *List) add(value int) {
	newNode := &Node{data: value}

	if l.head == nil {
		l.head = newNode
		return
	}

	curr := l.head
	for curr.next != nil {
		curr = curr.next
	}

	curr.next = newNode
}

func (l *List) remove(value int) {
	if l.head == nil {
		return
	}

	if l.head.data == value {
		l.head = l.head.next
		return
	}

	curr := l.head
	for curr.next != nil && curr.next.data != value {
		curr = curr.next
	}

	if curr.next != nil {
		curr.next = curr.next.next
	}
}

func main() {
	list := &List{}
	list.add(1)
	list.add(2)
	list.add(3)
	list.add(4)

	fmt.Println(list)

	fmt.Println("after remove 1")
	list.remove(1)
	fmt.Println(list)
}

func (l *List) String() string {
	curr := l.head
	var str string
	for curr != nil {
		str += fmt.Sprintf("%d ", curr.data)
		curr = curr.next
	}
	return str
}
