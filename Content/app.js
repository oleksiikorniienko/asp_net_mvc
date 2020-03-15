console.log('ok');

let storage = {};

let productContainer = document.getElementById('product-container');
productContainer.onclick = function (e) {
    let target = e.target;

    if (target.tagName != 'BUTTON') {
        return;
    }

    let id = target.parentNode.querySelectorAll('input[name="id"]')[0].value;
    let count = target.parentNode.querySelectorAll('input[name="count"]')[0].value;
    let price = target.parentNode.querySelectorAll('input[name="price"]')[0].value;

    count = parseInt(count);
    price = parseInt(price);

    if (storage.hasOwnProperty(id)) {
        storage[id].count += count;
    } else {
        storage[id] = { count, price };
    }

    calcCart();
};

function calcCart() {
    let totalCount = 0;
    let totalPrice = 0;

    for (let item in storage) {
        totalCount += storage[item].count;
        totalPrice += (storage[item].count * storage[item].price);
    }

    document.getElementById('products-count').innerHTML = totalCount;
    document.getElementById('products-price').innerHTML = totalPrice;
}
