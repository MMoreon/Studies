import numpy as np
from concurrent.futures import ThreadPoolExecutor
import time


def strassen_multiply(a, b):
    n = len(a)

    if n == 1:
        return a * b

    # Разбиваем матрицы на подматрицы
    a11, a12 = a[:n // 2, :n // 2], a[:n // 2, n // 2:]
    a21, a22 = a[n // 2:, :n // 2], a[n // 2:, n // 2:]

    b11, b12 = b[:n // 2, :n // 2], b[:n // 2, n // 2:]
    b21, b22 = b[n // 2:, :n // 2], b[n // 2:, n // 2:]

    # Вычисление подматриц
    p1 = strassen_multiply(a11 + a22, b11 + b22)
    p2 = strassen_multiply(a21 + a22, b11)
    p3 = strassen_multiply(a11, b12 - b22)
    p4 = strassen_multiply(a22, b21 - b11)
    p5 = strassen_multiply(a11 + a12, b22)
    p6 = strassen_multiply(a21 - a11, b11 + b12)
    p7 = strassen_multiply(a12 - a22, b21 + b22)

    # Вычисляем блоки результата
    c11 = p1 + p4 - p5 + p7
    c12 = p3 + p5
    c21 = p2 + p4
    c22 = p1 - p2 + p3 + p6

    # Собираем матрицу из блоков
    return np.vstack((np.hstack((c11, c12)), np.hstack((c21, c22))))


a = np.array([[2, 3], [4, 5]])
b = np.array([[6, 7], [8, 9]])

result = strassen_multiply(a, b)
start = time.time()
print(result)
end = time.time()
finish = end - start
print("За время: ", finish)
# Сложность: O(nlog(n))