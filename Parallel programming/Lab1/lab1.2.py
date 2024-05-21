# Решение системы литнейных алгебраических уравнений с трехдиагональной матрицей

from concurrent.futures import ThreadPoolExecutor
import time

def pryamo(a_m, b_m, c_m, d_m): 
    n = len(d_m)
    for i in range(1, n):
        multiplier = a_m[i-1] / b_m[i-1]
        b_m[i] = b_m[i] - multiplier * c_m[i-1]
        d_m[i] = d_m[i] - multiplier * d_m[i-1]
    return a_m, b_m

def obratno(a_m, b_m, c_m, d_m, a, b, i):  
    n = len(d_m)
    x = [0] * n

    x[-1] = d_m[-1] / b_m[-1]
    for i in range(n-2, -1, -1):
        x[i] = (d_m[i] - c_m[i] * x[i+1]) / b_m[i]
    return x

def otvet(a_m, b_m, c_m, d_m):
    n = len(d_m)
    a, b = pryamo(a_m, b_m, c_m, d_m)
    with ThreadPoolExecutor(max_workers=4) as executor:
        results = [executor.submit(obratno, a_m, b_m, c_m, d_m, a, b, i) for i in range(n)]
        return [result.result() for result in results]

a_m = [2, 2, 0]  # диагональ ниже главной
b_m = [8, 6, 4]  # главная диагональ
c_m = [2, 2, 0]  # диагональ выше главной
d_m = [16, 24, 8]  # вектор 

start = time.time()
res = otvet(a_m, b_m, c_m, d_m)
finish = time.time()
vremya = finish - start

print("результат", res[0], "за время", vremya)
