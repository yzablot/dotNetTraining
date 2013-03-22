#Task 1

Write C# console application that takes 2 files with integers in sorted order and merges them into one file.

* Project name should be Merger
* File names are passed via first 2 arguments.
* Output file name is given by third argument.
* Each file contains integers - one per line in non-decreasing order.
* Output file should contain all integers from input files, also in non-decreasing order.

For example:

input1.txt has content
```
1
3
5
5
7
```

and input2.txt has content
```
2
2
4
6
```

Result of running

```
Merger.exe input1.txt input2.txt output.txt
```

should be file output.txt with content:

```
1
2
2
3
4
5
5
6
7
```