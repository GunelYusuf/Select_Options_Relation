$("#model").change(function () {
  const change = $("#model option:selected").val()
    $.ajax({
        url: "/home/change?modelId=" + change,
        method: "get",
        success: function (res) {
            $("#marka option").next().remove() 
            $("#marka").append(res)
        }
    })
});




