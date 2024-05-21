// вычисление многочлена в точке


function vichisleniya(k, p, x) {
  return k * Math.pow(x, p);
}

function mnogochlen(k, x) {
  const n = k.length;
  if (n === 0) {
    return 0;
  }

  return k.reduce((sum, value, index) => {
    return sum + vichisleniya(value, index, x);
  }, 0);
}

const kof = [2, 9, 12];
const x = 1;
const result_func = mnogochlen(kof, x);
console.log(result_func);
