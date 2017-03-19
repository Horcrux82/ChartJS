var CHART = document.getElementById("lineChart");
Chart.defaults.scale.ticks.beginAtZero = true;
var myChart = new Chart(CHART,{
  type: "bar",
  data:{
    labels: ["mickeymouse","donald trump","Hillary Clinton"],
    datasets:[{
      label:"2016 Elections",
      backgroundColor: [
                'rgba(144, 66, 120, 0.5)',
'rgba(187, 69, 234, 0.5)',
'rgba(245, 14, 111, 0.5)',
'rgba(133, 33, 178, 0.2)'
            ],
      borderWidth: 5,
      data:[5,20,10],
    }]
  },

});
