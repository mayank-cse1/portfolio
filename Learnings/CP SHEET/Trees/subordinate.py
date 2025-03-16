class TreeNode:
    def __init__(self):
        self.val = 0
        self.children = []
        self.childrenCount = 0
n = int(input())
seq = list(map(int,input().split()))
visited = {}
for i,ele in enumerate(seq):
    #i - employee, ele - boss
    if ele not in visited:
        curr = TreeNode()
        curr.val = ele
        visited[ele] = curr
    if i+2 not in visited:
        curr = TreeNode()
        curr.val = i+2
        visited[i+2] = curr
    curr = visited[i+2]
    visited[ele].children.append(curr)
    visited[ele].childrenCount += 1

output = dict()
def helper(root):
    if root.childrenCount == 0:
        output[root.val] = 0
        return 0
    ans = 0
    for child in root.children:
        ans += helper(child)
    ans += root.childrenCount 
    output[root.val] = ans
    return ans
temp = helper(visited[1])
for i in range(1,n+1):
    if i in output:
        print(output[i], end = " ")
    else:
        print(0, end=" ")