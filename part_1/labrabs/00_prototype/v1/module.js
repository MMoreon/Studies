const getRandomArray = (len, maxNumber) => {
    return new Array(len)
        .fill(0)
        .map(elm => Math.floor((Math.random() * maxNumber)))
}

const getIndexElement = (arr, value, start = 0, end = arr.length -1) => {
    let index = 0;
    let middle = Math.floor(end+start)/2;

    if(arr[middle] === value){
        index = middle;

    }else if(arr[middle] > value){
        //  end = middle - 1; без рекурсии
        getIndexElement(arr, value, start, middle - 1); // рекурсивно
    }else{
        //  start = middle + 1; без рекурсии
        getIndexElement(arr, value, middle + 1 , end) // рекурсивно
    }

    return index
}

module.exports = {
    getRandomArray,
    getIndexElement
}