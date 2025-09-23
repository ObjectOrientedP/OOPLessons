void printPreorder(Node node) {
    if(node == null) {
        return
    }  
    System.out.print(node.key + " ");
    printPreorder(node.left);
    printPreorder(node.right);
}

void printInOrder(Node node) {
    if(node == null) {
        return
    }  
    printInOrder(node.left);
    System.out.print(node.key + " ");
    printInOrder(node.right);
}