import numpy as np
import time

# Метод итерации
def f(x):
    N = len(x)
    if N <= 1:
        return x
    even = f(x[::2])
    odd = f(x[1::2])
    t = 1
    factor = np.exp(-2j * np.pi / N)

    for i in range(N // 2):
        x[i] = even[i] + t * odd[i]
        x[i + N // 2] = even[i] - t * odd[i]
        t = t * factor
    
    return x

x = np.array([0, 2, 3, 4])
result = f(x)
start = time.time()
print(result)
end = time.time()
finish = end - start
print("За время: ", finish)
# Сложность: O(nlogn)