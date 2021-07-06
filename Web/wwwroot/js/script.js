////$(".cart-item").click(function () {
////    console.log("Salam");
////})

$(function () {
    let cookieValue = Cookies.get("cartItem");
    if (typeof cookieValue !== 'undefined' && cookieValue != 0) {
        cookieValue = [...cookieValue.split("-")];
        console.log(cookieValue.length)
        $(".prod-count").html(cookieValue.length);

    }
    let productIds = cookieValue ?? [];
    $(".cart-item").click(function () {
        const basketId = $(this).attr("basketid");
        const plusminus = $(".plus-minus-cart");
        if (typeof plusminus !== 'undefined') {
            let plusminusVal = plusminus.val();
            for (var i = 0; i < plusminusVal; i++) {
                productIds.push(basketId);
            }
            plusminus.val(1);
        }
        else
        {
            productIds.push(basketId);
        }
        productIds.push(basketId);
        Cookies.set("cartItem", productIds.join('-'), { expires: 7 });
        $(".prod-count").html(productIds.length);

        Swal.fire({
            position: 'center',
            icon: 'success',
            title: 'Product added to cart!',
            showConfirmButton: false,
            timer: 1500
        })  
        $("prod-count").html(cookieValue.length);
       
    })  
})