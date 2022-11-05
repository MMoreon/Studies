import random as r 
import time

def sort(lst):
    for i in range(1, len(lst)):
        key = lst[i]
        j = i-1
        while j >=0 and key < lst[j] :
            lst[j+1] = lst[j]
            j -= 1
        lst[j+1] = key

t_start = time.monotonic()

count = 1000
lst = [r.randint(0, count) for i in range(count)]

print("Random" + str(lst))
sort(lst)
print("Sort: " + str(lst))

t_stop = time.monotonic()

t_run = t_stop - t_start
print(t_run)
