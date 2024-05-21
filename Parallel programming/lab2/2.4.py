import numpy as np

a = np.array([1, 2, 3])  # Коэффициенты на главной диагонали
b = np.array([4, 5, 6])  # Коэффициенты на первой дополнительной диагонали
c = np.array([7, 8, 9])  # Коэффициенты на второй дополнительной диагонали
d = np.array([10, 11, 12])  # Вектор свободных членов

n = len(a)

alpha = np.zeros(n)
beta = np.zeros(n)

# Вычисление коэффициентов прогонки
alpha[0] = c[0] / b[0]
beta[0] = d[0] / b[0]
for i in range(1, n):
    alpha[i] = c[i] / (b[i] - a[i] * alpha[i-1])
    beta[i] = (d[i] - a[i] * beta[i-1]) / (b[i] - a[i] * alpha[i-1])

# Нахождение решения
x = np.zeros(n)
x[-1] = beta[-1]
for i in range(n-2, -1, -1):
    x[i] = beta[i] - alpha[i] * x[i+1]

print(x)
