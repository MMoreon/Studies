import joblib


def identity(x):
  return x


def parallel_sum(numbers):
  result = joblib.Parallel(n_jobs=-1)(joblib.delayed(identity)(num)
                                      for num in numbers)
  return sum(result)


if __name__ == "__main__":
  numbers = [1, 6, 3, 4, 5]
  result = parallel_sum(numbers)
  print(f"Сумма: {result}")
      