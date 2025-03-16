class TreeNode:
    def __init__(self):
        self.val = 0
        self.child = None
        # self.childrenCount = 0
n = int(input())
visited = {}
ans = 0
def edge(a,b):
    if a not in visited:
        curr = TreeNode()
        curr.val = a
        visited[a] = curr
    if b not in visited:
        curr = TreeNode()
        curr.val = b
        visited[b] = curr
    if visited[a].child == None:
        visited[a].child = visited[b]
        
for _ in range(1,n):
    a,b = list(map(int,input().split()))
    if a not in visited or visited[a].child == None:
        ans +=1
        edge(a,b)
print(ans)