# Решение системы литнейных алгебраических уравнений с двухдиагональной матрицей

from numba import jit
import numpy as np


@jit(parallel=True)

def bidiag_matrix(a, b, c, d):
    n = len(d)
    x = np.zeros(n)


    for i in range(1, n):
        m = a[i-1] / b[i-1]
        b[i] -= m * c[i-1]
        d[i] -= m * d[i-1]
    

    x[-1] = d[-1] / b[-1]
    for i in range(n-2, -1, -1):
        x[i] = (d[i] - c[i] * x[i+1]) / b[i]
    
    return x

a = np.array([2])  # Поддиагональ
b = np.array([2, 4])  # Главная диагональ
c = np.array([2])  # Наддиагональ
d = np.array([1, 2])  # Вектор правой части

itog = bidiag_matrix(a, b, c, d)
print(itog)