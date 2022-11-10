def sort_bubble(lst):
    n = len(lst)
    for j in range(1, n):
        for i in range(n-j):
            if lst[i] > lst[i+1]:
                lst[i], lst[i+1] = lst[i+1], lst[i]
    return lst