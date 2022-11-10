import random as r
import time

def sort(a):
    for i in range(1, len(a)):
        for j in range(i+1, num):
            if a[i] > a[j]:
                a[i], a[j] = a[j], a[i]

t_start = time.monotonic()

num = int(input("Количество цифр:"))
a = [r.randint(0,num) for i in range(num)]


sort(a)
print("Sort:" + str(a))

t_stop = time.monotonic()
t_run = t_stop - t_start
print(t_run)