def sort_bubble_plus(lst):
    n = len(lst)
    for j in range(1, n):
        swap = False  # была ли замена элементов
        for i in range(n-j):
            if lst[i] > lst[i+1]:
                lst[i], lst[i+1] = lst[i+1], lst[i]
                swap = True
        if not swap:  # всё уже отсортировано
            break
    return lst