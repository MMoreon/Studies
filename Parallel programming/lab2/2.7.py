import numpy as np

def gaussian_elimination(A, b):
    n = len(b)
    
    # Прямой ход метода Гаусса
    for i in range(n):
        for j in range(i+1, n):
            factor = A[j, i] / A[i, i]
            A[j, i:] -= factor * A[i, i:]
            b[j] -= factor * b[i]
    
    # Обратный ход метода Гаусса
    x = np.zeros(n, dtype=float)
    for i in range(n-1, -1, -1):
        x[i] = (b[i] - np.dot(A[i, i+1:], x[i+1:])) / A[i, i]
    
    return x

# Матрица коэффициентов
A = np.array([[3, 2, 3], [1, 3, 2], [1, 2, 3]], dtype=float)
# Вектор свободных членов
b = np.array([5, 3, 3], dtype=float)

# Решение системы уравнений
solution = gaussian_elimination(A, b)
print("Решение системы уравнений:")
print(solution)
