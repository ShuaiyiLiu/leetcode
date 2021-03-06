# 394. Decode String

## 分类
* 栈
* 有限状态机

## 解法
我们需要两个栈，一个用于存储数据，一个用于存储字符串。题意保证了输入是有效的，所以我们可以依此扫描每个字符，并且分为下面的四种情况：

* **数字：** 用一个计数变量来计数，把字符转换成数值。
* **左括号 [** 遇到左括号说明我们需要开始解析一段新的字符串，并且在遇到右括号以后作为一个整体处理。所以我们需要把之前记下来的数值和之前保存下来的字符串压入栈中，并且清空计数和字符串，开始新的解码。
* **右括号 ]** 右括号表示一段字符串的结束。我们需要把栈里的数值N弹出，然后把当前记录的字符串重复输出N遍。然后从字符串栈中弹出之前的字符串，把新产生的字符串添加在后面。
* **其他字符** 其他字符直接保存进当前的字符串里。

* 时间复杂度：`O(n)`
* 空间复杂度：`O(1)`

## 边界条件
无

## 备注
无

## 参考文献
无