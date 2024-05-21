import numpy as np

# Задаем матрицы A и B заранее
A = np.array([[1, 2,3],
              [4, 5, 6],
              [7, 8, 9]])

B = np.array([[1,2,3],
              [4,5,6],
             [7,8,9]])

# Вычисляем результат выражения A^T(B+B^T)A
result = np.dot(np.dot(A.T, B + B.T), A)

print(result)