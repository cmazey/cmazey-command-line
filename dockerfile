FROM python:3.12
RUN pip install --upgrade pip
ENV FILE_TO_RUN="/ccl.py"
WORKDIR "/CMD-REPL"
COPY ccl.py ./
CMD ["sh", "-c", "python ${FILE_TO_RUN}"]
