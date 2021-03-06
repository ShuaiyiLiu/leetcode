# 285. Inorder Successor in BST

## 分类
* 二叉查找树

## 解法
### 直观的解法
用两个指针中序遍历二叉树，慢指针比快指针慢一步。慢指针到达目标节点的时候，快指针就是它的后继节点。

* 时间复杂度：`O(n)`
* 空间复杂度：`O(1)`

### 最好的解法
利用BST的性质，可以实现小于`O(n)`时间复杂度的解法。对于BST而言，如果当前根节点的数值小于目标节点的数值，那么目标节点在根节点的右侧，否则在左侧。中序遍历时，如果向左遍历，那么后继节点就是当前节点。如果向右遍历，那么就需要从右子树开始继续向左遍历，直到到达叶节点为止。

* 时间复杂度：`O(logn)`
* 空间复杂度：`O(1)`

## 边界条件
无

## 备注
无

## 参考文献
无