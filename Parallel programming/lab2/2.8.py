import numpy as np

def fft(x):

    N = len(x)
    if N <= 1:
        return x
    
    even = fft(x[::2])
    odd = fft(x[1::2])
    
    factor = np.exp(-2j * np.pi / N)
    factor_odd = 1
    
    for i in range(N // 2):
        x[i] = even[i] + factor_odd * odd[i]
        x[i + N // 2] = even[i] - factor_odd * odd[i]
        factor_odd *= factor
    
    return x

# Пример использования
x = np.array([0, 1, 2, 3, 4, 5, 6, 7])
result = fft(x)
print("Результат FFT:")
print(result)
