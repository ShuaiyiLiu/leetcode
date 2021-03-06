# 76. Minimum Window Substring

## 分类
* 双指针

## 解法
初始化时先用一个数组或者哈希表来记录`t`字符串里每个字符出现的次数。用一个变量`count`来记录当前窗口中有效的（即存在于字符串`t`中的）字符的个数。
然后用两个指针来维护一个窗口，即窗口的起点`start`和终点`end`。首先判断`end`位置的字符是否在哈希表内，如果是的话，将其计数减一。然后判断该字符当前计数是否大于或等于零。如果是的话，说明是有效字符，那么将`count`加一，表示当前窗口内的有效字符数增加了一。接着判断有效字符的总数是否等于所需的有效字符数，等于的话就不断地移动起始位置，并适当修改有效字符的计数，直到有效字符少于所需的字符总数。此时可以进行下一次循环。

## 复杂度
* 时间复杂度：`O(n)`
* 空间复杂度：`O(1)`

## 边界条件
当不存在符合条件的子串时，应当返回空串。

## 备注
无

## 参考文献
无