import concurrent.futures

def evaluate_polynomial(coefficients, x):
    result = 0
    for i, coeff in enumerate(coefficients):
        result += coeff * (x ** i)
    return result

def evaluate_polynomial_parallel(coefficients, x):
    result = 0
    with concurrent.futures.ThreadPoolExecutor() as executor:
        futures = {executor.submit(evaluate_polynomial, coefficients, x): i for i, _ in enumerate(coefficients)}
        for future in concurrent.futures.as_completed(futures):
            result += future.result()
    return result

if __name__ == '__main__':
    coefficients = [1, -2, 4, 0, 2]  # Пример коэффициентов многочлена
    x = 3
  # Точка, в которой нужно вычислить многочлен

    result_serial = evaluate_polynomial(coefficients, x)
    result_parallel = evaluate_polynomial_parallel(coefficients, x)

    print(f"Значение многочлена в точке x={x} (параллельно): {result_serial}")
