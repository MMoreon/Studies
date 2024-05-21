# обращение двухдиагональной матрицы

import numpy as np
from concurrent.futures import ThreadPoolExecutor
import time

input_matrix = np.array([
    [12, 0, 6],
    [0, 4, 0],
    [3, 0, 2]
])

def inverse(matrix):

    inverse_matrix = np.linalg.inv(matrix)
    return inverse_matrix

with ThreadPoolExecutor(max_workers=6) as executor:
    result = executor.submit(inverse, input_matrix).result()

print("Обратная матрица:")
start_time = time.time()
print(result)
end_time = time.time()
execution_time = end_time - start_time
print(f"Время выполнения: {execution_time:.5f} секунд")
