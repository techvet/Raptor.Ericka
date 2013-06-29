/* Support list */

$("#slist a").click(function (e) {
    e.preventDefault();
    $(this).next('p').toggle(200);
});