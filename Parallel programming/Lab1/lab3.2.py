def gauss_elimination(A, b):
    n = len(A)


    for i in range(n):

        factor = A[i][i]
        for j in range(i, n):
            A[i][j] /= factor
        b[i] /= factor


        for k in range(i+1, n):
            factor = A[k][i]
            for j in range(i, n):
                A[k][j] -= factor * A[i][j]
            b[k] -= factor * b[i]


    x = [0] * n
    for i in range(n-1, -1, -1):
        x[i] = b[i]
        for j in range(i+1, n):
            x[i] -= A[i][j] * x[j]

    return x


A = [[1, 1, 0],
     [1, 2, 1],
     [0, 1, 3]]

b = [2, 6, 4]


solution = gauss_elimination(A, b)

print("Решение системы уравнений:")
print("x =", solution)