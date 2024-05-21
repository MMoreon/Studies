import numpy as np

def strassen_matrix_multiply(A, B):
    """
    Умножение матриц методом Штрассена.
    
    Параметры:
    A (numpy.ndarray): Первая матрица.
    B (numpy.ndarray): Вторая матрица.
    
    Возвращает:
    numpy.ndarray: Результат умножения матриц.
    """
    n = len(A)
    
    if n == 1:
        return A * B
    
    # Разбиение матриц на подматрицы
    a11, a12, a21, a22 = A[:n//2, :n//2], A[:n//2, n//2:], A[n//2:, :n//2], A[n//2:, n//2:]
    b11, b12, b21, b22 = B[:n//2, :n//2], B[:n//2, n//2:], B[n//2:, :n//2], B[n//2:, n//2:]
    
    # Рекурсивные вычисления
    p1 = strassen_matrix_multiply(a11 + a22, b11 + b22)
    p2 = strassen_matrix_multiply(a21 + a22, b11)
    p3 = strassen_matrix_multiply(a11, b12 - b22)
    p4 = strassen_matrix_multiply(a22, b21 - b11)
    p5 = strassen_matrix_multiply(a11 + a12, b22)
    p6 = strassen_matrix_multiply(a21 - a11, b11 + b12)
    p7 = strassen_matrix_multiply(a12 - a22, b21 + b22)
    
    # Вычисление результата
    c11 = p1 + p4 - p5 + p7
    c12 = p3 + p5
    c21 = p2 + p4
    c22 = p1 - p2 + p3 + p6
    
    # Объединение результатов
    C = np.vstack((np.hstack((c11, c12)), np.hstack((c21, c22))))
    
    return C

# Пример использования
A = np.array([[1, 2, 3, 4], [5, 6, 7, 8], [9, 10, 11, 12], [13, 14, 15, 16]])
B = np.array([[1, 0, 0, 1], [0, 1, 1, 0], [1, 0, 0, 1], [0, 1, 1, 0]])
result = strassen_matrix_multiply(A, B)
print("Результат умножения матриц методом Штрассена:")
print(result)
