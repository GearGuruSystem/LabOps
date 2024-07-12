document.addEventListener('DOMContentLoaded', function () {
    const rowsPerPage = 25;
    let currentPage = 1;
    const table = document.getElementById('tabela-Equipamentos');
    const tbody = table.querySelector('tbody');
    const rows = Array.from(tbody.rows);
    const searchInput = document.getElementById('searchInput');

    function renderTable(page) {
        tbody.innerHTML = '';
        const start = (page - 1) * rowsPerPage;
        const end = start + rowsPerPage;
        const filteredRows = rows.filter(row => row.style.display !== 'none');
        filteredRows.slice(start, end).forEach(row => tbody.appendChild(row));
        updatePagination(filteredRows.length);
    }

    function updatePagination(totalRows) {
        const pagination = document.getElementById('pagination');
        pagination.innerHTML = '';
        const totalPages = Math.ceil(totalRows / rowsPerPage);
        for (let i = 1; i <= totalPages; i++) {
            const button = document.createElement('button');
            button.textContent = i;
            button.className = i === currentPage ? 'active btn btn-primary mx-1' : 'btn btn-secondary mx-1';
            button.onclick = function () {
                currentPage = i;
                renderTable(currentPage);
            };
            pagination.appendChild(button);
        }
    }

    function sortTable(columnIndex) {
        const isAsc = table.querySelectorAll('th')[columnIndex].classList.toggle('asc');
        rows.sort((a, b) => {
            const aText = a.cells[columnIndex].textContent.trim();
            const bText = b.cells[columnIndex].textContent.trim();
            return isAsc ? aText.localeCompare(bText) : bText.localeCompare(aText);
        });
        renderTable(currentPage);
    }

    searchInput.addEventListener('input', function () {
        const filter = searchInput.value.toLowerCase();
        rows.forEach(row => {
            const cells = Array.from(row.cells);
            const match = cells.some(cell => cell.textContent.toLowerCase().includes(filter));
            row.style.display = match ? '' : 'none';
        });
        updatePagination(rows.filter(row => row.style.display !== 'none').length);
        renderTable(1);
    });

    renderTable(currentPage);

    $(".btn-detalhes").click(function () {
        var id = $(this).attr('idEquipamento');
        console.log(id)

        $.ajax({
            type: 'GET',
            url: '/Equipamento/Detalhes/' + id,
            success: function (result) {
                $("#detalhesEquipamento").html(result);
                $('#modalDetalhesEquipamentos').modal("show");
            }, error: function () {
                console.log("Deu bololo");
            }
        });
    });





});