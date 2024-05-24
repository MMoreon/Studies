import numpy as np
from concurrent.futures import ThreadPoolExecutor

def multiply_rows(row_a, matrix_b): 
    return np.dot(row_a, matrix_b)

def parallel_matrix_multiply(matrix_a, matrix_b):
    with ThreadPoolExecutor() as executor:
        multiplied_rows = list(executor.map(lambda row: multiply_rows(row, matrix_b), matrix_a))
    return np.vstack(multiplied_rows) 

a = np.array([[2, 1], [4, 3]])
b = np.array([[6, 5], [8, 7]])

result = parallel_matrix_multiply(a, b)
print(result)