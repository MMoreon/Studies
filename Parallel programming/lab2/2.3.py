import numpy as np

def solve_two_diagonal_system(a, b, c, d):

    n = len(d)
    x = np.zeros(n)
     
    # обратная подстановка
    x = [0] * n
    x[-1] = d[-1] / b[-1]

    for i in range(n-2, -1, -1):
        x[i] = (d[i] - c[i] * x[i+1]) / b[i]

    return x

# Пример системы уравнений
a = np.array([1, 2, 3])  # Коэффициенты на главной диагонали
b = np.array([5, 6, 7])  # Коэффициенты на первой дополнительной диагонали
c = np.array([9, 10, 11])  # Коэффициенты на второй дополнительной диагонали
d = np.array([12, 13, 14])  # Вектор свободных членов


solution = solve_two_diagonal_system(a, b, c, d)
print("Решение системы уравнений:")
print(solution)
