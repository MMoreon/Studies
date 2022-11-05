import random as r
import time

def sort(a):
  for i in range(1, len(a)):
    for j in range(1, num-1-i):
      if a[j] > a[j+1]:
        a[j], a[j+1] = a[j+1], a[j]
      

t_start = time.monotonic()

num = int(input("Количество цифр:"))
a = [r.randint(0,num) for i in range(num)]


sort(a)
print("Sort:" + str(a))

t_stop = time.monotonic()
t_run = t_stop - t_start
print(t_run)
