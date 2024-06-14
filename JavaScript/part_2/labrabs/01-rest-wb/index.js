const request = require('sync-request');
// npm i sync-request
const fs = require("fs");


const get_json_from_url = (link, headers, sortAsc, sortDesc) => {
    try { // REST API - wb
        let resp = request('GET', link, { headers });
        let json = JSON.parse(resp.getBody('utf8'));
        let products = json.data.products; // выбрали только products
        console.log(JSON.stringify(products[0], null, 4));
        console.log(products.length);

        let FilterProduct = products.map(product => ({
            brand: product.brand,
            colors: product.colors,
            name: product.name,
            basePrice: product.price?.basic || 0,
            currentPrice: product.price?.product || 0,
            rating: product.rating,
            reviewCount: product.review_count
        }));

        products.sort(sortFunctions[sortAsc][sortDesc]);

        saveToFile("product.json" , JSON.stringify(FilterProduct, null , 2));
    } catch (e) { 
        console.log(e);
    }
}

const sortFunctions = {
    price: {
        asc: (a, b) => (a.basePrice || 0) - (b.PriceBase || 0),
        desc: (a, b) => (b.basePrice || 0) - (a.basePrice || 0)
    },
    popular: {
        asc: (a, b) => a.rating - b.rating,
        desc: (a, b) => b.rating - a.rating
    },
    rating: {
        asc: (a, b) => a.reviewCount - b.reviewCount,
        desc: (a, b) => b.reviewCount - a.reviewCount
    }
};



const saveToFile = (filename, data) => {
    try {
        fs.writeFileSync(filename, data, 'utf8');
        console.log('Данные сохранены', filename);
    } catch (err) {
        console.error('Ошибка', err);
    }
}


let host = "https://search.wb.ru/";
let rout = "exactmatch/ru/male/v5/search";

let queryStr = "page=1&ab_testing=false&appType=1&curr=rub&dest=12358373&query=ноутбук&resultset=catalog&sort=popular&spp=30&suppressSpellcheck=false&uclusters=1&uiv=2";

// требуется преобразовать строку запроса если там кириллица в Unicode
let query = new URLSearchParams(queryStr)
let decodedParams = {};

for (let [key, value] of query.entries()) {
  decodedParams[key] = decodeURIComponent(value);
}

// .toString(); // можно так - ver 1
// можно через stringify + replace - ver 2
// на этой лабе требуется через Object.keys() - ver 3



let headers = require("./headers.json");

let url = `${host}${rout}?${query.toString()}`;

get_json_from_url(
    url,
    headers,
    'price',
    'asc'
);
