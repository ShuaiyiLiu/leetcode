# 246. Strobogrammatic Number 

## 分类
* 双指针

## 解法
0-9这些数字中，一共有四组旋转对称的数字，0和0，1和1，8和8，6和9. 从左右两边开始向中间搜索，遇到不属于上述四对对称数字中的数字就可以返回`false`了。

* 时间复杂度：`O(n)`
* 空间复杂度：`O(1)`

## 边界条件
五

## 备注
无

## 参考文献
无